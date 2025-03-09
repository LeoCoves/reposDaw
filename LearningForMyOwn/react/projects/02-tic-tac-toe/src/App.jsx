import { useState } from 'react'
import './App.css'
import { Square } from './components/Square.jsx'
import { TURNS, WINNER_COMBOS } from './constants.js'
import { WinnerModal } from './components/WinnerModal.jsx'
import confetti from 'canvas-confetti'


function App() {
  const [board, setBoard] = useState(() => {
    const boardFromStorage = localStorage.getItem('board')
    return boardFromStorage 
    ? JSON.parse(boardFromStorage) // Si es true el boardFromStorage
    : Array(9).fill(null) // Si no hay nada en el local storage
  })

  const [turn, setTurn] = useState(() => {
    const turnFromStorage = localStorage.getItem('board-turn')
    return turnFromStorage
    ?? TURNS.X // Si es null o undefined el localStorage
  })
  const [winner, setWinner] = useState(null)

  const checkWinner = (boardToCheck) => {
    for (const combo of WINNER_COMBOS){
      const [a, b, c] = combo

      if(
        boardToCheck[a] &&
        boardToCheck[a] === boardToCheck[b] &&
        boardToCheck[b] === boardToCheck[c]
      ){
        return boardToCheck[a]
      }

      return null
    }
  }

  const resetGame = () => {
    setBoard(Array(9).fill(null))
    setTurn(TURNS.X)
    setWinner(null)

    localStorage.removeItem('board')
    localStorage.removeItem('board-turn')
  }

  const checkEndGame = (boardToCheck) => {
    return boardToCheck.every(cell => cell !== null)
  }
  
  const updateBoard = (index) => {
    //Si la celda ya esta ocupada, no hacer nada
    if(board[index] || winner) return

    //Actualizar el tablero
    const newBoard = [...board]
    newBoard[index] = turn
    setBoard(newBoard)

    //Actualizar el turno
    const newTurn = turn === TURNS.X ? TURNS.O : TURNS.X
    setTurn(newTurn)

    //Guardar la partida en el local storage
    localStorage.setItem('board', JSON.stringify(newBoard))
    localStorage.setItem('board-turn', newTurn)

    //Revisar si hay ganador
    const newWinner = checkWinner(newBoard)
    if(newWinner){
      confetti()
      setWinner(newWinner)
    }
    else if(checkEndGame(newBoard)){
      setWinner(false)
    }
  }

  return (
    <main className="board">
      <h1>Tres en ralla!</h1>
      <button onClick={resetGame}>
        Reiniciar
      </button>
      <section className="game">
        {
          board.map((cell, index) => {
            return(
              <Square key={index} index={index} updateBoard={updateBoard} >
                {cell}
              </Square>
            )
          })
        }
      </section>

      <section className='turn'>
        <Square isSelected={turn === TURNS.X}>
          {TURNS.X}
        </Square>
        <Square isSelected={turn === TURNS.O}>
          {TURNS.O}
        </Square>
      </section>

      <WinnerModal winner={winner} resetGame={resetGame} />
    </main>
  )
}

export default App
