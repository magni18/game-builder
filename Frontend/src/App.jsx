import { useState } from 'react'
import './App.css'
import { GameCreatorSession } from './pages/GameCreatorSession'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <GameCreatorSession/>
    </>
  )
}

export default App
