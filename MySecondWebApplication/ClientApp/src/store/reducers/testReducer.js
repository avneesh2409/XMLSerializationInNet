import { GET_TEST, HISTORY_PUSH } from "../constants";

export const testInitial = {}
const testReducer = (state = testInitial, action) => {
    switch (action.type) {
        case GET_TEST:
            return {
                ...state,
                test:action.payload
            }
        case HISTORY_PUSH:
            state.router.location = action.url
            return {
                ...state,
                router: state.router
            }
        default:
            return state;
    }
}
export default testReducer;