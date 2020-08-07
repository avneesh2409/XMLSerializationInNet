import React from 'react'
import Layout from '../components/Layout'
import { Route, Redirect } from 'react-router'
import SchoolComponent from '../components/child/SchoolComponent'
import StudentComponent from '../components/child/StudentComponent'
import Logout from '../components/child/LogoutForm'
import Login from '../components/child/LoginForm'
import Register from '../components/child/RegisterForm'
import Home from '../components/home'

const Router = () => {
    return (
        <Layout>
            <Route exact path='/' render={() => <Home />} />
            <Route exact path='/home' render={() => <Redirect to="/" />} />
            <Route exact path='/school' render={() => <SchoolComponent />} />
            <Route exact path='/student' render={() => <StudentComponent />} />
            <Route exact path='/logout' render={() => <Logout />} />
            <Route exact path='/login' render={() => <Login />} />
            <Route exact path='/register' render={() => <Register />} />
        </Layout>
    )
}
export default Router