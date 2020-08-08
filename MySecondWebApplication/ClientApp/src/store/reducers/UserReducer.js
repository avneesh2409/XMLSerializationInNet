import {REGISTER_USER_REQUEST, REGISTER_USER_RESPONSE, REGISTER_USER_ERROR } from '../constants'

export const UserInitial = {
    loading: false,
    error: '',
    data: null
}
const UserReducer = (state = UserInitial, action) => {
    switch (action.type) {
        case REGISTER_USER_REQUEST:
            return {
                ...state,
                loading: true
            }
        case REGISTER_USER_RESPONSE:
            return {
                ...state,
                loading: false,
                data: action.data
            }
        case REGISTER_USER_ERROR:
            return {
                ...state,
                loading: false,
                error: action.error
            }
        default: return state;
    }
}
export default UserReducer
