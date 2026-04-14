import { GameCreationSessionCoreData } from "../data/dataobjects/GameCreationSessionDatas";
import { GetSession, StoreSession } from "../data/SessionDataStoring";

export function GameCreatorSession() {

    const sessionId = "test-session-id";

    return (
        <div>
            <h1>Game Creator Session</h1>
            <div>
                <p> Session Id is {sessionId ? sessionId : "not found"} </p>
                <button onClick={async () => {
                    const sessionData = { ...GameCreationSessionCoreData };
                    sessionData.SessionId = sessionId;
                    const data = await StoreSession(sessionData);
                    console.log("Session data stored in component:", data);
                }}>
                    Create Session
                </button>
                <button onClick={async () => {
                    const session = await GetSession(sessionId);
                    console.log("Session data retrieved in component:", session);
                }}>
                    Get Session
                </button>
            </div>
        </div>
    )
}