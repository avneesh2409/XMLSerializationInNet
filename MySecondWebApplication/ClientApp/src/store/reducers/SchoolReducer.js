import { FETCH_SCHOOL_REQUEST, FETCH_SCHOOL_RESPONSE, FETCH_SCHOOL_ERROR } from '../constants';

const initial = {
    loading: false,
    data: null,
    error:''
}
const SchoolReducer = (state = initial, action) => {

    switch (action.type) {
        case FETCH_SCHOOL_REQUEST:
            return {
                ...state,
                loading: true
            }
        case FETCH_SCHOOL_RESPONSE:
            return {
                ...state,
                loading: false,
                data: action.data
            }
        case FETCH_SCHOOL_ERROR:
            return {
                ...state,
                loading: false,
                error: action.error
            }
        default: return state;
    }
}
export default SchoolReducer;