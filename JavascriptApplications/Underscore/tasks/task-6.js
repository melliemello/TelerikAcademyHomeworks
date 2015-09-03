/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (books) {
  	var groupedByAuthor = _.chain(books)
  	.each(function(book) {
  		book.author.fullName = book.author.firstName + ' ' + book.author.lastName;
  	})
    .sortBy(function(group) {
      return group.author.fullName;
    })
    .groupBy(function(book) {
      return book.author.fullName;
    })
    .value();

    var maxNumberOfBooks = _.chain(groupedByAuthor)
    .max(function(group){
      return group.length;
    })
    .value()
    .length;

    _.chain(groupedByAuthor)
    .each(function(group){
      if(group.length === maxNumberOfBooks) {
        console.log(group[0].author.fullName);
      }
    });




  };
}

module.exports = solve;
