// Nav function resource: http://www.w3schools.com/howto/howto_js_topnav.asp responsive menu tutorial
function nav() {
    var a = document.getElementById("upper-nav");
    if (a.className === "uppernav") {  // if statement checks to see if class is equal to mobile class
        a.className += " mobile";
    } else {
        a.className = "uppernav";  // if not, keep the class as non-mobile  
    }
}

setInterval(function () {
    moveElectronCX("#electron0", 548, 1040);
    moveElectronCX("#electron3", 1900, 2750);
    moveElectronCXBack("#electron4", 2650, 2050);
    moveElectronCXBack("#electron5", 2600, 2450);
    moveElectronAngle("#electron6", 1526, 1310, 1120);
    moveElectronCYDown("#electron2", 574, 700);
    moveElectronCYUP("#electron1", 684, 540);
    moveElectronCXBack("#electron7", 2650, 1640);
    moveElectronCYUP("#electron8", 1250, 1000);
}, 5);
function moveElectronCYDown(target, start, max) {
    currCY = jQuery(target).attr("cy");
    currCY = parseInt(currCY);
    newCY = currCY + 10;
    newCY = parseInt(newCY);
    if (currCY < max) {
        jQuery(target).attr("cy", newCY);
    }
    else {
        jQuery(target).attr("cy", start);
    }
}
function moveElectronCYUP(target, start, min) {
    currCY = jQuery(target).attr("cy");
    currCY = parseInt(currCY);
    newCY = currCY - 10;
    newCY = parseInt(newCY);
    if (currCY > min) {
        jQuery(target).attr("cy", newCY);
    }
    else {
        jQuery(target).attr("cy", start);
    }
}

function moveElectronCX(target, start, max) {
    currCX = jQuery(target).attr("cx");
    currCX = parseInt(currCX);
    newCX = currCX + 10;
    newCX = parseInt(newCX);
    if (currCX < max) {
        jQuery(target).attr("cx", newCX);
    }
    else {
        jQuery(target).attr("cx", start);
    }
}
function moveElectronCXBack(target, start, min) {
    currCX = jQuery(target).attr("cx");
    currCX = parseInt(currCX);
    newCX = currCX - 10;
    newCX = parseInt(newCX);
    if (currCX > min) {
        jQuery(target).attr("cx", newCX);
    }
    else {
        jQuery(target).attr("cx", start);
    }
}

function moveElectronAngle(target, iniX, iniY, min) {
    currCX = jQuery(target).attr("cx");
    currCX = parseInt(currCX);
    currCY = jQuery(target).attr("cy");
    currCY = parseInt(currCY);
    newCX = currCX - 10;
    newCX = parseInt(newCX);
    newCY = currCY - 5.5;
    newCY = parseInt(newCY);
    if (currCX > min) {
        jQuery(target).attr("cx", newCX);
        jQuery(target).attr("cy", newCY);
    }
    else {
        jQuery(target).attr("cx", iniX);
        jQuery(target).attr("cy", iniY);
    }
}
