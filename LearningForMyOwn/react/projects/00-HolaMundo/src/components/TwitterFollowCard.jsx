import { useState } from "react";

export function TwitterFollowCard({name="unknown", username="unknown", imgSrc, initialIsFollowing=false}) {
    const [isFollowing, setIsFollowing] = useState(initialIsFollowing);   
    
    const addAt = (username) => `@${username}`;
    username = addAt(username);

    const textButton = isFollowing ? "Siguiendo" : "Seguir";
    const buttonClassName  = isFollowing 
    ? "tw-followCard-button is-following" 
    : "tw-followCard-button";

    const handleClick = () => {
        setIsFollowing(!isFollowing);
    }
    
    return(
        <article className="tw-followCard">
            <header className="tw-followCard-header">
                <img src={imgSrc} alt={`Imagen de ${username}`}  className="tw-followCard-avatar"/>
                <div className="tw-followCard-info">
                    <strong>
                        {name}
                    </strong>
                    <span>
                        {username}
                    </span>
                </div>
            </header>

            <aside className="tw-followCard-actions">
                <button className={buttonClassName} onClick={handleClick}>
                    <span className="tw-followCard-follow">
                    {textButton}
                    </span>
                    <span className="tw-followCard-stopFollow">
                        Dejar de seguir
                    </span>
                </button>
            </aside>
        </article>
    )
}