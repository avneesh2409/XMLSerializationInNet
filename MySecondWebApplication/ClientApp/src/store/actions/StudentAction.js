import { STUDENT_FETCH_URL, FETCH_STUDENT_REQUEST, FETCH_STUDENT_RESPONSE, FETCH_STUDENT_ERROR } from "../constants"

export const fetchStudentData = (token) => {
    const options = {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Authorization': `Bearer ${token}`
        }
    }
    return (dispatch) => {
        dispatch(fetchStudentRequest())
        fetch(STUDENT_FETCH_URL, options)
            .then(res => res.json())
            .then(json => dispatch(fetchStudentResponse(json)))
            .catch(err => dispatch(fetchStudentError(err.message)))
    }
}

export const fetchStudentRequest = () => {
    return {
        type: FETCH_STUDENT_REQUEST
    }
}
export const fetchStudentResponse = (data) => {
    return {
        type: FETCH_STUDENT_RESPONSE,
        data
    }
}
export const fetchStudentError = (error) => {
    return {
        type: FETCH_STUDENT_ERROR,
        error
    }
}