document.addEventListener("DOMContentLoaded", function () {
    const cards = document.querySelectorAll('.movie-card');
    cards.forEach((card, index) => {
        setTimeout(() => {
            card.style.opacity = 1;
        }, index * 300);
    });
});