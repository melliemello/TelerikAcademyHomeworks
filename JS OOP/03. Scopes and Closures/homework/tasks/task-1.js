/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and isbn
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	author is any non-empty string
			*	Unique params are Book title and Book isbn
			*	Book isbn is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		function listBooks(params) {
			var booksToDisplay = books.slice(),
				param;
			if(arguments.length){
				param  = Object.keys(params)[0];
				booksToDisplay = booksToDisplay.filter(function(element){
					return element[param] === params[param];
				});
			}

			return booksToDisplay.sort(function(a,b){
				a.id - b.id;
			});
		}

		function addBook(book) {
			if(_isValidBook(book)){
				_addBookTo(book.category, book);
				book.ID = books.length + 1;
				books.push(book);
				return book;
			}else{
				throw new Error();
			}
		}

		function listCategories() {
			var categoriesToDisplay = [];
			categories.reduce(function(arr,element){
				categoriesToDisplay.push(element.name);
			},categoriesToDisplay)
			return categoriesToDisplay;
		}

		function _addBookTo(category, book){
			if(_isUniqueCategory(category)){
				categories.push({id:categories.length + 1, name:book.category});
			}
		}

		function _isUniqueBook(book){
			var existingBooks = books.filter(function(element){
				return element.title === book.title
				|| element.isbn === book.isbn;
			});
			return existingBooks.length < 1;
		}

		function _isUniqueCategory(category){
			var existingCategories = categories.filter(function(element){
				return element.name === category;
			});
			return existingCategories.length < 1;
		}

		function _isValidBook(book){
			var isbnLength = book.isbn.toString().length;
			if(!_isUniqueBook(book)
				|| ! _stringLengthIsBetween(2,100, book.title)
				|| book.author.length < 1
				|| (isbnLength != 10 && isbnLength != 13)
				){
				return false;
			}

			return true;
		}

		function _isValidVategory(category){
			if(! _stringLengthIsBetween(2,100, category.name)){
				return false;
			}
			return true;
		}

		function _stringLengthIsBetween(from,to, string){
			var length = string.length;
			if(length < from || length > to){
				return false;
			}
			return true;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;




