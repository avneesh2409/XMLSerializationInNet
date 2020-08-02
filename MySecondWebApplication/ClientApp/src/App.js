import * as React from 'react';
import {Route, Redirect } from 'react-router';
import Layout from './components/Layout';
import Home from './components/home';
import './custom.css'
import { useSelector } from 'react-redux';

export default () => {
    const { testReducer } = useSelector(state => state);
    return (

        <Layout>
            <Route exact path='/' component={Home} />
            <Route exact path='/home' render={() => <Redirect to="/" />} />
            <Route exact path='/contact' render={() => <h1>hello from contact page {JSON.stringify(testReducer)}</h1>} />
            <Route exact path='/event' render={() => <h1>hello from event page{JSON.stringify(testReducer)}</h1>} />
            <Route exact path='/library' render={() => <h1>hello from library page{JSON.stringify(testReducer)}</h1>} />
        </Layout>
    )
}
