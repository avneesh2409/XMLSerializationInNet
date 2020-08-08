import React from 'react';
import { Link } from 'react-router-dom';
import styles from '../../css/register.module.css';

const Login = () => {
    return (
        <div className={styles.wrapper}>
            <div className={styles.container}>
                <h1>Login</h1>
                <p>Login Here</p>
                <hr />
                <label htmlFor="email"><b>Email</b></label>
                <input type="text" placeholder="Enter Email" name="email" id="email" required />
                <label htmlFor="psw"><b>Password</b></label>
                <input type="password" placeholder="Enter Password" name="psw" id="psw" required />

                <button type="submit" className={styles.registerbtn}>Login</button>
            </div>

            <div className={styles.container, styles.signin}>
                <p>don't have an account? <Link to="/register">Sign up Here</Link>.</p>
            </div>
        </div>
    )
}

export default Login;