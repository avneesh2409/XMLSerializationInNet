import { applyMiddleware, combineReducers, compose, createStore } from 'redux';
import thunk from 'redux-thunk';
import { connectRouter, routerMiddleware } from 'connected-react-router';
import { reducers } from './reducers';
import { initialState } from './reducers/getInitial';


export default function configureStore(history) {
    
    const middleware = [
        thunk,
        routerMiddleware(history)
    ];

    const rootReducer = combineReducers({
        ...reducers,
        router: connectRouter(history)
    });

    const enhancers = [];
    const windowIfDefined = typeof window === 'undefined' ? null : window;
    if (windowIfDefined && windowIfDefined.__REDUX_DEVTOOLS_EXTENSION__) {
        enhancers.push(windowIfDefined.__REDUX_DEVTOOLS_EXTENSION__());
    }

    return createStore(
        rootReducer,
        initialState,
        compose(applyMiddleware(...middleware), ...enhancers)
    );
}
