function solve(){
  return function(selector){
    var options = {
    	wrapperClass: 'dropdown-list',
    	currentClass: 'current',
    	optionsContainerClass: 'options-container',
    	dropdownItemClass: 'dropdown-item'
    	},
    	$select = $(selector),
    	$options = $select.children('option'),
    	$dropdownItem = $('<div class="' + options.dropdownItemClass + '"></div>');

    var $pluginWrapper = $select
    	.wrap('<div class="'+ options.wrapperClass +'"></div>')
    	.parent();

    var $selectedOption  = $('<div class="'+ options.currentClass +'">'+ $options.first().text() +'</div>');

    var $optionsContainer = $('<div class="'+ options.optionsContainerClass +'"></div>')
    	.css({position: 'absolute', display: 'none'});

    $options.each(function(index){
    	var $currentOptionClone = $dropdownItem.clone(true)
    		.attr('data-value', $(this).val())
    		.attr('index', index)
    		.html($(this).text());
    	$optionsContainer.append($currentOptionClone);
    });

    $select.css('display', 'none');
    $pluginWrapper.append($selectedOption).append($optionsContainer);

    $selectedOption.on('click', function(){
    	$(this).next().toggle();
    });

    $optionsContainer.on('click', '.' + options.dropdownItemClass, function(){
    	console.log($(this).attr('data-value'));
    	$selectedOption
    		.attr('data-value', $(this).attr('data-value'))
    		.text($(this).text());

    	$select.val($(this).attr('data-value'));
    	$optionsContainer.hide();
    });
  };
}

module.exports = solve;