using System;


    public class AppState
    {
        public string FavoriteAnimal { get; set; }
        
        public event Action OnFavoriteAnimalChange;

        public void SetFavoriteAnimal(string favoriteAnimal)
        {
            FavoriteAnimal = favoriteAnimal;
            OnFavoriteAnimalChange?.Invoke();
        }
    }

