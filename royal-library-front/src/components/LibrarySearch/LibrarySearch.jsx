import React, { useState } from 'react'
import './LibrarySearch.css'
import { getBooksBySearch } from '../../services/LibraryService'
import BookTable from '../BookTable/BookTable'

function LibrarySearch() {
  const [searchType, setSearchType] = useState('')
  const [searchValue, setSearchValue] = useState('')
  const [books, setBooks] = useState([])

  const onSearch = async () => {
    try {
      const result = await getBooksBySearch(searchType, searchValue)
      setBooks(result)
    } catch (error) {}
  }

  return (
    <div>
      <h1>Royal Library</h1>
      <div className="library-search">
        <form>
          <div className="search-by-wrapper">
            <label htmlFor="search-by">Search By:</label>
            <select
              id="search-by"
              value={searchType}
              onChange={(e) => setSearchType(e.target.value)}
            >
              <option value="">Select</option>
              <option value="author">Author</option>
              <option value="isbn">ISBN</option>
            </select>
          </div>
          <div className="search-by-wrapper">
            <label htmlFor="search-value">Search Value:</label>
            <input
              type="text"
              id="search-value"
              value={searchValue}
              onChange={(e) => setSearchValue(e.target.value)}
              required
            />
          </div>
          <div>
            <button type="button" onClick={onSearch}>
              Search
            </button>
          </div>
        </form>
      </div>
      {!!books.length && <BookTable books={books} />}
    </div>
  )
}

export default LibrarySearch
