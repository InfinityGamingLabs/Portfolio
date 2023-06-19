const BASE_URL = 'http://localhost:8000/api/';

// Function to get all games
async function getGames() {
  try {
    const response = await axios.get(`${BASE_URL}games`);
    return response.data;
  } catch (error) {
    console.error(error);
  }
}

// Function to get a single game by ID
async function getGameById(id) {
  try {
    const response = await axios.get(`${BASE_URL}games/${id}`);
    return response.data;
  } catch (error) {
    console.error(error);
  }
}

// Function to add a new game
async function addGame(game) {
  try {
    const response = await axios.post(`${BASE_URL}games`, game);
    return response.data;
  } catch (error) {
    console.error(error);
  }
}

// Function to update an existing game
async function updateGame(id, game) {
  try {
    const response = await axios.put(`${BASE_URL}games/${id}`, game);
    return response.data;
  } catch (error) {
    console.error(error);
  }
}

// Function to delete a game by ID
async function deleteGame(id) {
  try {
    const response = await axios.delete(`${BASE_URL}games/${id}`);
    return response.data;
  } catch (error) {
    console.error(error);
  }
}

// Function to get all reviews for a game
async function getReviewsForGame(id) {
  try {
    const response = await axios.get(`${BASE_URL}games/${id}/reviews`);
    return response.data;
  } catch (error) {
    console.error(error);
  }
}

// Function to add a review for a game
async function addReviewForGame(id, review) {
  try {
    const response = await axios.post(`${BASE_URL}games/${id}/reviews`, review);
    return response.data;
  } catch (error) {
    console.error(error);
  }
}

// Get a reference to the DOM element where the game list will be displayed
const gameListElement = document.querySelector('#game-list');

// Call the getGames function to retrieve a list of games from the API
getGames().then(games => {
  // Loop through the games and create an HTML element for each one
  games.forEach(game => {
    const gameElement = document.createElement('li');
    gameElement.textContent = game.title;
    gameListElement.appendChild(gameElement);
  });
}).catch(error => {
  console.error(error);
});
