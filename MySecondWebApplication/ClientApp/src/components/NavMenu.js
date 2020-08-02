import React from 'react';
import { Link } from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.css';

const NavMenu = () => {
    const anchorStyle = {
        padding: '5px'
    }
        return (
            <header>
                    <nav className="navbar navbar-default">
                    <div className="container-fluid">
                        <ul style={{ listStyleType: 'none', paddingLeft: '0px' }}>
                            <Link style={anchorStyle} to="/home">Home</Link>
                            <Link style={anchorStyle} to="/contact">contact</Link>
                            <Link style={anchorStyle} to="/library">library</Link>
                            <Link style={anchorStyle} to="/event">event</Link>
                        </ul>
                        </div>
                    </nav>
            </header>
        );
}
export default NavMenu;