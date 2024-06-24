// let currentPage = 1;
// const quotesPerPage = 5;

// document.addEventListener('DOMContentLoaded', () => {
//     fetchQuotes(currentPage);

//     document.getElementById('prev-page').addEventListener('click', (e) => {
//         e.preventDefault();
//         if (currentPage > 1) {
//             currentPage--;
//             fetchQuotes(currentPage);
//         }
//     });

//     document.getElementById('next-page').addEventListener('click', (e) => {
//         e.preventDefault();
//         currentPage++;
//         fetchQuotes(currentPage);
//     });

//     document.getElementById('search-button').addEventListener('click', (e) => {
//         e.preventDefault();
//         const authorName = document.getElementById('author-search').value.trim();
//         if (authorName !== '') {
//             searchByAuthor(authorName);
//         }
//     });
// });

// function fetchQuotes(page) {
//     const skip = (page - 1) * quotesPerPage;
//     fetch(`https://dummyjson.com/quotes?limit=${quotesPerPage}&skip=${skip}`)
//         .then(response => response.json())
//         .then(data => displayQuotes(data.quotes))
//         .catch(error => console.error('Error fetching quotes:', error));
// }

// function searchByAuthor(authorName) {
//     fetch(`https://dummyjson.com/quotes?author=${encodeURIComponent(authorName)}`)
//         .then(response => response.json())
//         .then(data => {
//             // Filtered quotes based on author name
//             const filteredQuotes = data.quotes.filter(quote => quote.author.toLowerCase().includes(authorName.toLowerCase()));
//             displayQuotes(filteredQuotes);
//         })
//         .catch(error => console.error('Error searching quotes by author:', error));
// }

// function displayQuotes(quotes) {
//     const quotesContainer = document.getElementById('quotes-container');
//     quotesContainer.innerHTML = '';

//     quotes.forEach(quote => {
//         const quoteCard = document.createElement('div');
//         quoteCard.className = 'quote-card';
//         quoteCard.innerHTML = `
//             <p>${quote.quote}</p>
//             <div class="author">- ${quote.author}</div>
//         `;
//         quotesContainer.appendChild(quoteCard);
//     });

//     revealQuotes();
// }

// function revealQuotes() {
//     const quoteCards = document.querySelectorAll('.quote-card');
//     quoteCards.forEach((quoteCard, index) => {
//         setTimeout(() => {
//             quoteCard.classList.add('visible');
//         }, index * 500); // Change 500 to the desired delay in milliseconds
//     });
// }
let currentPage = 1;
const quotesPerPage = 5;
let currentSort = ''; // To track current sorting order

document.addEventListener('DOMContentLoaded', () => {
    fetchQuotes(currentPage);

    document.getElementById('prev-page').addEventListener('click', (e) => {
        e.preventDefault();
        if (currentPage > 1) {
            currentPage--;
            fetchQuotes(currentPage);
        }
    });

    document.getElementById('next-page').addEventListener('click', (e) => {
        e.preventDefault();
        currentPage++;
        fetchQuotes(currentPage);
    });

    document.getElementById('search-button').addEventListener('click', (e) => {
        e.preventDefault();
        const authorName = document.getElementById('author-search').value.trim();
        if (authorName !== '') {
            searchByAuthor(authorName);
        }
    });

    document.getElementById('sort-asc').addEventListener('click', () => {
        currentSort = 'asc';
        sortAndDisplayQuotes();
    });

    document.getElementById('sort-desc').addEventListener('click', () => {
        currentSort = 'desc';
        sortAndDisplayQuotes();
    });
});

function fetchQuotes(page) {
    const skip = (page - 1) * quotesPerPage;
    fetch(`https://dummyjson.com/quotes?limit=${quotesPerPage}&skip=${skip}`)
        .then(response => response.json())
        .then(data => displayQuotes(data.quotes))
        .catch(error => console.error('Error fetching quotes:', error));
}

function searchByAuthor(authorName) {
    fetch(`https://dummyjson.com/quotes?author=${encodeURIComponent(authorName)}`)
        .then(response => response.json())
        .then(data => {
            const filteredQuotes = data.quotes.filter(quote => quote.author.toLowerCase().includes(authorName.toLowerCase()));
            displayQuotes(filteredQuotes);
        })
        .catch(error => console.error('Error searching quotes by author:', error));
}

function displayQuotes(quotes) {
    const quotesContainer = document.getElementById('quotes-container');
    quotesContainer.innerHTML = '';

    // Sort quotes if there is a current sort order
    if (currentSort === 'asc') {
        quotes.sort((a, b) => a.author.localeCompare(b.author));
    } else if (currentSort === 'desc') {
        quotes.sort((a, b) => b.author.localeCompare(a.author));
    }

    quotes.forEach(quote => {
        const quoteCard = document.createElement('div');
        quoteCard.className = 'quote-card';
        quoteCard.innerHTML = `
            <p>${quote.quote}</p>
            <div class="author">- ${quote.author}</div>
        `;
        quotesContainer.appendChild(quoteCard);
    });

    revealQuotes();
}

function sortAndDisplayQuotes() {
    fetchQuotes(currentPage); // Fetch and display quotes will sort automatically in displayQuotes
}

function revealQuotes() {
    const quoteCards = document.querySelectorAll('.quote-card');
    quoteCards.forEach((quoteCard, index) => {
        setTimeout(() => {
            quoteCard.classList.add('visible');
        }, index * 500); // Delay each quote card reveal
    });
}
