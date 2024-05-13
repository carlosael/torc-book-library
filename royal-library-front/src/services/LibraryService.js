import axios from 'axios'

export const getBooksBySearch = async (searchType, searchValue) => {
  try {
    const response = await axios.get(`https://localhost:7218/api/Book`, {
      params: {
        [searchType]: searchValue,
      },
    })
    return response.data // return data from server
  } catch (error) {
    console.log(error)
  }
}
