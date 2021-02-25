# Library web app (ASP.NET MVC CORE + Entity Framework)


## Important(?)
If the database table data isn't stored in this project, to create an admin user you'll have to add a user with permission level 2 or 3 through  view data inside the database itself.

## General "workflow"
Non logged in users can browse books without reserving.\
User creates an account and logs in and reserves a book.\
Upon reservation the book is still available for reservation by others until the "Admin" accepts the reservation,  after which it gets removed from the "pool" of available books. 
When the reservation is accepted it's removed from the database (the entry gets dropped from the reservation table) and an entry gets added to the order table which has all the information about the book, user and reservation/return dates.\
User can check books reserved to his name in /User/MyBooks and he's informed about the date by which he has to return the book.\
Admin can list all orders under /Order/Transactions and he can confirm that a book was returned.


### To Fix/Refactor
Correct usage of asynchronous code (async/await/Task statements), and specifically chaining asynchronous events)\
Redesign the database schemas to make more logical sense\
Make code adhere stylistically to C# conventions\
Rename variables to make more logical sense

### Missing "core" features
SignalR real-time page updates

### Missing random features in a random order
Proper error handling\
Sorting all the content by any columns\
Popular page\
Multiple book genres per book\
Encrypted passwords\
Emailing upon reservation
