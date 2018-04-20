// Nav function resource: http://www.w3schools.com/howto/howto_js_topnav.asp responsive menu tutorial
function nav() {
    var a = document.getElementById("upper-nav");
    if (a.className === "uppernav") {  // if statement checks to see if class is equal to mobile class
        a.className += " mobile";
    } else {
        a.className = "uppernav";  // if not, keep the class as non-mobile  
    }
};