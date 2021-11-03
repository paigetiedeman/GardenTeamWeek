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