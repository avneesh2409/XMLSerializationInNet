import { FETCH_STUDENT_REQUEST, FETCH_STUDENT_RESPONSE, FETCH_STUDENT_ERROR } from '../constants'

export const StudentInitial = {
    loading: false,
    error: '',
    data: null
}
const StudentReducer = (state = StudentInitial, action) => {
    switch (action.type) {
        case FETCH_STUDENT_REQUEST:
            return {
                ...state,
                loading: true
            }
        case FETCH_STUDENT_RESPONSE:
            return {
                ...state,
                loading: false,
                data: action.data
            }
        case FETCH_STUDENT_ERROR:
            return {
                ...state,
                loading: false,
                error: action.error
            }
        default: return state;
    }
}
export default StudentReducer
