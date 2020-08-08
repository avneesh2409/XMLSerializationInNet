import { REGISTER_URL, REGISTER_USER_REQUEST, REGISTER_USER_RESPONSE, REGISTER_USER_ERROR } from "../constants"


export const registerUserAction = (payload) => {
    const options = {
        method:'POST',
        headers: {
            'Content-Type': 'application/json',
            'Accept':'application/json'
        },
        body: JSON.stringify(payload)
    }
    return (dispatch) => {
        dispatch(registerUserRequest())
        fetch(REGISTER_URL, options).then(res => res.json())
            .then(json => dispatch(registerUserResponse(json)))
            .catch(err => dispatch(registerUserError(err.message)))
    }
}

export const registerUserRequest = () => {
    return {
        type: REGISTER_USER_REQUEST
    }
}
export const registerUserResponse = (data) => {
    if (data) {
        alert("successfully registered");
    }
    else {
        alert("unable to registered");
    }
    return {
        type: REGISTER_USER_RESPONSE,
        data
    }
}
export const registerUserError = (error) => {
    alert("unable to registered");
    return {
        type: REGISTER_USER_ERROR,
        error
    }
}

