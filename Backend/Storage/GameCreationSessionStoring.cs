public class GameCreationSessionStoring
{
    public void StoreSession(GameCreationSession session)
    {
        try
        {
            using (var db = new GameCreationSessionContext())
            {
                db.CreationSessions.Add(session);
                db.SaveChanges();
            }   
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving session to database: {ex.InnerException?.Message}");
            Console.WriteLine($"Error storing session: {ex.Message}");
            return;
        }
    }

    public GameCreationSession? GetSession(string sessionId)
    {
        using (var db = new GameCreationSessionContext())
        {
            try
            {
                var session =
                    db.CreationSessions.FirstOrDefault(s => s.SessionId == sessionId);
                
                if (session != null)
                {
                    return session;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving session: {ex.Message}");
            }
        }

        return null;
    }
}