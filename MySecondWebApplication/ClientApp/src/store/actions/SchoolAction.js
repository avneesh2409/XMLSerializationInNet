import { SCHOOL_FETCH_URL, FETCH_SCHOOL_REQUEST, FETCH_SCHOOL_RESPONSE, FETCH_SCHOOL_ERROR } from "../constants"

export const fetchSchoolData = (token) => {
    const options = {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Authorization':`Bearer ${token}`
        }
    }
    return (dispatch) => {
        dispatch(fetchSchoolRequest())
        fetch(SCHOOL_FETCH_URL, options)
            .then(res => res.json())
            .then(json => dispatch(fetchSchoolResponse(json)))
            .catch(err => dispatch(fetchSchoolError(err.message)))
    }
}

export const fetchSchoolRequest = () => {
    return {
        type: FETCH_SCHOOL_REQUEST
    }
}
export const fetchSchoolResponse = (data) => {
    return {
        type: FETCH_SCHOOL_RESPONSE,
        data
    }
}
export const fetchSchoolError = (error) => {
    return {
        type: FETCH_SCHOOL_ERROR,
        error
    }
}