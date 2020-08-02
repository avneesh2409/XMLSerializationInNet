import { HISTORY_PUSH } from "../constants"

export const push = (url) =>{
    return {
        type: HISTORY_PUSH,
        url
    }
}