// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let posterCardArr = document.querySelectorAll(".MovieCard")
let hiddenPosterCardArr = document.querySelectorAll(".MovieCardHidden")
let colseBtnArr = document.querySelectorAll('.CloseBtn')
posterCardArr.forEach((card, i) => {
    card.addEventListener('click', () => {
        console.log('clicked', hiddenPosterCardArr[i])
        if (hiddenPosterCardArr[i].style.display != "block") {
            console.log('in', hiddenPosterCardArr[i])
            hiddenPosterCardArr[i].style.display = "block"
        }


    })
})

colseBtnArr.forEach((item, i) => {
    item.addEventListener('click', () => {
        console.log('clicked', hiddenPosterCardArr[i])
        if (hiddenPosterCardArr[i].style.display == "block") {
            console.log('in', hiddenPosterCardArr[i])
            hiddenPosterCardArr[i].style.display = "none"
        } else {
            hiddenPosterCardArr[i].style.display = "block"
        }
    })
})

