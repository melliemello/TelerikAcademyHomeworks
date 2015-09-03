function solve(){
  return function(){
    $.fn.listview = function(data){
      var templateId = '#' + $(this).attr('data-template'),
      	templateString = $(templateId).html(),
      	template = handlebars.compile(templateString);

      	for(var i = 0, len = data.length; i < len; i++){
      		$(this).append(template(data[i]));
      	}
    };
  };
}

module.exports = solve;