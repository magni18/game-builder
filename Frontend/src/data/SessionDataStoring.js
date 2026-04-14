import { BackendURL } from "./BackendURL";

export async function GetSession(sessionId) {

    try{
        const response = await fetch(`${BackendURL}/get-session/${sessionId}`, { 
            method: "GET",
            headers: {
                "Content-Type": "application/json"
            }
        })

        if (!response.ok){
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        const sessionData = await response.json();
        console.log("Session data retrieved:", sessionData);

        return sessionData;
    }
    catch(error){
        console.error("Error fetching session:", error);
    }
}

export async function StoreSession(sessionData) {
    console.log("Storing session data:", sessionData);

    try{
        const response = await fetch(`${BackendURL}/create-session`, { 
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(sessionData)
        })

        if (!response.ok){
            throw new Error(`HTTP error! status: ${response.status}`);
        }
    }
    catch(error){
        console.error("Error fetching session:", error);
    }
}