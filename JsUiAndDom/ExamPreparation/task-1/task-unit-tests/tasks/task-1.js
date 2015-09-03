/* globals module */
function solve() {

  function clear(node) {
    while (node.firstChild) {
      node.removeChild(node.firstChild);
    }
  }

  return function (selector, items) {
    var selectedElement = document.querySelector(selector),
    main = document.createElement('div'),
    aside = document.createElement('div'),
    inputElement = document.createElement('input'),
    imagePreviewElement = document.createElement('img'),
    mainImageTitle = document.createElement('h1'),
    imageList;

    clear(selectedElement);
    setMainFrames();
    setInputTo(aside, inputElement);
    setImageGalleryTo(aside, items);
    imageList = document.querySelectorAll('.image-container');
    setPreviewerTo(main, imagePreviewElement);

    aside.addEventListener('click', function(evt){
        if(evt.target.nodeName === 'IMG'){
            imagePreviewElement.src = evt.target.src;
            mainImageTitle.innerHTML = evt.target.previousElementSibling.innerHTML;
        }
        console.log(imageList);
    });

    aside.addEventListener('mouseover', function(e){
        if(e.target.nodeName === 'IMG'){
            e.target.parentNode.style.background = 'gray';
        }
    });

    aside.addEventListener('mouseout', function(e){
        if(e.target.nodeName === 'IMG'){
            e.target.parentNode.style.background = '';
        }
    });

    inputElement.addEventListener('keyup', function(evt){
        var value = this.value,
            imageTitle;
        for(var i =0; i <imageList.length; i++){
            imageTitle = imageList[i].querySelector('h2').innerHTML;
            if(imageTitle.toLowerCase().indexOf(value.toLowerCase()) < 0){
                imageList[i].style.display = 'none';
            }else{
                imageList[i].style.display = 'block';
            }
        }
    });

    function setMainFrames(){
        main.style.width = '80%';
        main.style.float = 'left';
        aside.style.width = '20%';
        aside.style.float = 'left';
        selectedElement.appendChild(main);
        selectedElement.appendChild(aside);
    }

    function setPreviewerTo(parent, imageElement){ 
        var previewWrapper = document.createElement('div');
            previewWrapper.classList.add('image-preview');
            imageElement.src = items[0].url;
            imageElement.style.width = '80%';
            imageElement.style.margin = '0 auto';
            mainImageTitle.innerHTML = items[0].title;

            previewWrapper.appendChild(mainImageTitle);
            previewWrapper.appendChild(imageElement);
            parent.appendChild(previewWrapper);
    }

    function setImageGalleryTo(parent, items){
        var imageElement = document.createElement('img'),
            currentImageElement,
            imageWrapper = document.createElement('li'),
            currentImageWrapper,
            titleElement = document.createElement('h2'),
            currentTitleElement,
            fragment = document.createDocumentFragment();
            imageWrapper.classList.add('image-container');

        for(var i = 0; i < items.length; i++){
            currentImageWrapper = imageWrapper.cloneNode(true);
            currentImageElement = imageElement.cloneNode(true);
            currentTitleElement = titleElement.cloneNode(true);

            currentTitleElement.innerHTML = items[i].title;
            currentImageElement.src = items[i].url;
            currentImageElement.style.width = '100%';

            currentImageWrapper.appendChild(currentTitleElement);
            currentImageWrapper.appendChild(currentImageElement);
            fragment.appendChild(currentImageWrapper);
        }

        parent.appendChild(fragment);
    }

    function setInputTo(parent, inputElement){
        var titleElement = document.createElement('h3');
        titleElement.innerHTML = 'Filter';
        parent.appendChild(titleElement);
        parent.appendChild(inputElement);
    }
}

module.exports = solve;