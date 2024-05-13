import React from 'react'
import './BookTable.css'

const BookTable = ({ books }) => {
  return (
    <div>
      <h2>Search Results:</h2>
      <table>
        <thead>
          <tr>
            <th>Book Title</th>
            <th>Authors</th>
            <th>Type</th>
            <th>ISBN</th>
            <th>Category</th>
            <th>Available Copies</th>
          </tr>
        </thead>
        <tbody>
          {books.map((book) => (
            <tr key={book.bookId}>
              <td>{book.title}</td>
              <td>{`${book.firstName} ${book.lastName}`}</td>
              <td>{book.type}</td>
              <td>{book.isbn}</td>
              <td>{book.category}</td>
              <td>{`${book.totalCopies - book.copiesInUse} / ${
                book.totalCopies
              }`}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  )
}

export default BookTable
