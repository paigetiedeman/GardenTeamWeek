const tile = document.querySelector('#tile');
const tile2 = document.querySelector('#tile2');
const tile3 = document.querySelector('#tile3');
const tile4 = document.querySelector('#tile4');
const tile5 = document.querySelector('#tile5');
const tile6 = document.querySelector('#tile6');


tile.addEventListener('dragstart', dragStart);
tile2.addEventListener('dragstart', dragStart);
tile3.addEventListener('dragstart', dragStart);
tile4.addEventListener('dragstart', dragStart);
tile5.addEventListener('dragstart', dragStart);
tile6.addEventListener('dragstart', dragStart);


//text/uri-list
function dragStart(e) {
  e.dataTransfer.setData('text/plain', e.target.id);
  setTimeout(() => {
    e.target.classList.add('hide');
  }, 0);
  console.log('drag starts...');
  console.log(e.target.id);
}

const wrapper = document.querySelectorAll('#drop-panel');

wrapper.forEach(panel => {
  panel.addEventListener('dragenter', dragEnter);
  panel.addEventListener('dragover', dragOver);
  panel.addEventListener('dragleave', dragLeave);
  panel.addEventListener('drop', drop);
});

function dragEnter(e) {
  e.preventDefault();
  e.target.classList.add('drag-over');
}

function dragOver(e) {
  e.preventDefault();
  e.target.classList.add('drag-over');

}

function dragLeave(e) {
  e.target.classList.remove('drag-over');

}

function drop(e) {
  e.target.classList.remove('drag-over');

  const id = e.dataTransfer.getData('text/plain');
  console.log(id);
  const draggable = document.getElementById(id);

  e.target.appendChild(draggable);
  
  draggable.classList.remove('hide');
  e.dataTransfer.clearData();


  console.log('drag droppppping');
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