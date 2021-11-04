function allowDrop(ev) {
  ev.preventDefault();
  ev.target.classList.Remove("dragged");
}

function drag(ev) {
  ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
  ev.preventDefault();
  var data = ev.dataTransfer.getData("text");
  ev.target.appendChild(document.getElementById(data)).classList.add("dragged");
}

  function returnSeed(ev) {
  ev.preventDefault();
  var data = ev.dataTransfer.getData("text");
  ev.target.appendChild(document.getElementById(data)).classList.remove("dragged");
  }

function divVisibility(divId) {
  if(visibleDivId === divId) {
    visibleDivId = null;
  } else {
    visibleDivId = divId;
  }
  hideNonVisibleDivs();
}

function hideNonVisibleDivs() {
  for(let i=0; i < divs.length; i++){
    divId = divs[i];
    div = document.getElementById(divId);
    if(visibleDivId === divId){
      div.style.display = "block";
    } else {
      div.style.display = "none"
    }
  }
}

const divs = ["left-side", "left-side2", "left-side3", "left-side4", "right-side", "right-side2", "right-side3", "right-side4"];
let visibleDivId = null;



$(document).ready(function () {
  $(window).scroll(function () {
    if ($(this).scrollTop()) {
      $('#myBtn').fadeIn();
    } else {
      $('#myBtn').fadeOut();
    }
  });
  $('#myBtn').click(function () {
    $('html, body').animate({ scrollTop: 0 }, 300);
  });
});