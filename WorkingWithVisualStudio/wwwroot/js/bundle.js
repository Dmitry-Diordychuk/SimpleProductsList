document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "This is the element form the (modified) third.js file";
    document.querySelector("body").appendChild(element);
});
document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "This is the element from the third.js file";
    document.querySelector("body").appendChild(element);
});