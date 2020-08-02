import { GET_TEST } from "../constants"

export const testAction = (payload) => {
    return {
        type: GET_TEST,
        payload
    }
}