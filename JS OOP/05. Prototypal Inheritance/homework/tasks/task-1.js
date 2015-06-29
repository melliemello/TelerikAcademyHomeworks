/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {

	var domElement = (function () {
		var domElement = {
			init: function(type) {
        this._attributes = {};
        this._children = [];
        this.type = type;
        this.parent;
        this.content = "";
        return this;
			}
	  };

    Object.defineProperties(domElement, {
      appendChild:{
        value: function(child){
          if(typeof(child) === 'object'){
            child.parent = this;
          }

          this._children.push(child);
          return this;
        }
      },

      addAttribute: {
        value: function(name, value){
          if(isValidAttribute(name)){
          this._attributes[name] = value;
        }
        else{
          throw new Error();
        }
        return this;
        }
      },

      removeAttribute: {
        value: function(name){
          if(this._attributes[name]){
          delete this._attributes[name];
        }
        else{
          throw new Error;
        }
        return this;
        }
      },

      innerHTML: {
        get: function(){
          var childrenCount = this._children.length,
          attributesToAppend = printAttributes(this.attributes),
          result = '<' + this.type + attributesToAppend + '>' + this.content ;

          if(childrenCount){
            for(var i = 0; i < childrenCount; i++ ){
              result += this._children[i].innerHTML || this._children[i];
            }
          }

          result += '</' + this.type + '>';
          return result;
        }
      },

      type: {
        get: function(){
          return this._type;
        },
        set: function(value){
          if(value.length && value.match(/^[0-9A-Za-z]*$/)){
            this._type = value;
          }
          else{
            throw new Error();
          }
        }
      },

      parent: {
        get: function(){
          return this._parent;
        },
        set: function(parent){
          if(typeof(parent) === 'object'){
            this._parent = parent;
          }
        }
      },

      content: {
        get: function(){
          return this._content;
        },
        set: function(content){
          if(this._children.length === 0 && typeof(content) === 'string'){
            this._content  = content;
          }
        }
      },

      attributes: {
        get: function(){
          var self = this,
              orderedAttributes = {},
              orderedKeys = Object.keys(self._attributes).sort(function(a,b){
                return a < b ? -1: 1;
                return 0;
              });

          orderedKeys.forEach(function(key){
            orderedAttributes[key] =self._attributes[key];
          });

          return orderedAttributes;
        }
      },
      children:{
        get: function(){
          return this._children.slice();
        }
      }
    }) 

    function isValidAttribute(name){
      if(name.length && name.match(/^[0-9A-Za-z-]*$/)){
        return true;
      }
    }

    function printAttributes(attributes){
      var result = '';
      for (var attribute in attributes){
        result += ' ' + attribute + '="' + attributes[attribute] + '"';
      }
      return result;
    }
		return domElement;
	} ());

	return domElement;
}

module.exports = solve;
