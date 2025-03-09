import {Square } from './Square.jsx'

export function WinnerModal({winner, resetGame}){
    if(winner === null) return null;
    const winnerText = winner ? 'Ganador' + winner : 'Empate'

    return(
              <section className='winner'>
                <div className='text'>
                    <h2>
                      {
                        winnerText
                      }
                    </h2>
    
                    <header>
                      {
                        winner && <Square>{winner}</Square>
                      }
                    </header>
    
                    <footer>
                      <button onClick={resetGame}>
                        Reiniciar
                      </button>
                    </footer>
                </div>
              </section>
            )
}
