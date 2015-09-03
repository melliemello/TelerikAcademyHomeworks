/* globals $ */
$.fn.gallery = function (columns) {
	var numberOfCols = columns || 4,
		$gallery = this,
		$galleryList = $('.gallery-list'),
		$imageWrappers = $gallery.find('.image-container'),
		$images = $gallery.find('.image-container img'),
		$selected = $gallery.find('.selected'),
		$currentImage = $selected.find('.current-image img'),
		$previousImage = $selected.find('.previous-image img'),
		$nextImage = $selected.find('.next-image img'),
		$disableDiv = $('<div>').addClass('disabled-background ').css('display', 'none').appendTo($gallery);
	
	
	$gallery.addClass('gallery');
	$selected.css('display', 'none');
	
	$imageWrappers.each(function(index, image){
		if(index % numberOfCols === 0){
			$(image).addClass('clearfix');
		}
	});
	
	$gallery.on('click', 'img', function(){
		$galleryList.addClass('blurred');
		$selected.css('display', 'block');
		$disableDiv.css('display', 'block');
		updateSelected($(this));
	});
	
	$currentImage.on('click', function(e){
		$galleryList.removeClass('blurred');
		$selected.css('display', 'none');
		$disableDiv.css('display', 'none');
		e.stopPropagation();
	});
	
	$nextImage.on('click', function(e){
		updateSelected($(this));
		e.stopPropagation();
	});

	$previousImage.on('click', function(e){
		updateSelected($(this));
		e.stopPropagation();
	});
	
	function updateSelected(image){
		var currentElementIndex = image.attr('data-info') - 1,
			currentElement =  $images.eq(currentElementIndex),
			prevElement = $images.eq(currentElementIndex - 1),
			nextElement =  $images.eq(currentElementIndex + 1);
			
		$currentImage.attr('src', currentElement.attr('src'));
		$currentImage.attr('data-info', currentElement.attr('data-info'));
		$previousImage.attr('src', prevElement.attr('src'));
		$previousImage.attr('data-info', prevElement.attr('data-info'));
		$nextImage.attr('src', nextElement.attr('src'));
		$nextImage.attr('data-info', nextElement.attr('data-info'));
	}
	
};