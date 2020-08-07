import React from 'react';
import { Link } from 'react-router-dom';
import styles from '../css/styles.module.css';

const NavMenu = () => {

        return (
            <header>
                <nav className={styles.navWrapper}>
                    <div className={styles.navContainer}>
                        <ul className={styles.ulNavContainer}>
                            <Link className={styles.anchorStyle} to="/home">Home</Link>
                            <Link className={styles.anchorStyle} to="/school">School</Link>
                            <Link className={styles.anchorStyle} to="/student">Student</Link>
                        </ul>
                        <ul className={styles.rightAlign}>
                                <Link className={styles.anchorStyle} to="/register">Register</Link>
                                <Link className={styles.anchorStyle} to="/login">Login</Link>
                                <Link className={styles.anchorStyle} to="/logout">Logout</Link>
                        </ul>
                    </div>
                   
                </nav>
            </header>
        );
}
export default NavMenu;