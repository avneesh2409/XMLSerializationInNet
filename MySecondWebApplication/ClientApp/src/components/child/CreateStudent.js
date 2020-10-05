import React, { useState, useEffect } from 'react'
import styles from '../../css/create.module.css'
import { SCHOOL_FETCH_URL, STUDENT_ADD_URL } from '../../store/constants';
import { useSelector } from 'react-redux';
import {
    DocumentCardPreview,
    DocumentCardTitle } from '@fluentui/react/lib/DocumentCard';

const CreateStudent = () => {
    const { token } = useSelector(s => s.UserReducer);
    const initial = {
        name: '',
        schoolId: '',
        address:''
    }
    const [state, setState] = useState(initial)
    const submitHandler = () => {
        if (state.name && state.address) {
            fetch(STUDENT_ADD_URL, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                    'Accept': 'application/json',
                    'Authorization': `Bearer ${token}`
                },
                body: JSON.stringify({
                    name: state.name,
                    schoolId: parseInt(state.schoolId),
                    address: state.address
                })
            })
                .then(res => res.json())
                .then(json => {
                    if (json) {
                        alert("successfully registered")
                        setState(initial)
                    }
                    else {
                        alert("something went wrong")
                    }
                })
            .catch(err=>alert("unable to register"))
        }
        else {
            alert("All Fields are Required")
        }
    }
    const [schools, setSchools] = useState([]);
    const changeHandler = (e) => {
        setState({
            ...state,
            [e.target.name]: e.target.value
        })
    }
    useEffect(() => {
        fetch(SCHOOL_FETCH_URL, { method: 'GET', headers: { 'Accept': 'application/json', 'Authorization': `Bearer ${token}` } })
            .then(res => res.json())
            .then(json => setSchools(json))
            .catch(err => setSchools([]))
    }, [])
    return (
        <div className={styles.container}>
            <h1>Register Student</h1>
            
            <div>
                <label htmlFor="fname">Student Name</label>
                <input type="text" className={styles.global} id="fname" name="name" placeholder="Your Student Name.." value={state.name} onChange={changeHandler} />

                <label htmlFor="address">Address</label>
                <input type="text" className={styles.global} id="address" name="address" placeholder="Your Student Address.." value={state.address} onChange={changeHandler} />

                <label htmlFor="country">Country</label>
                <select className={styles.global} name="schoolId" onChange={changeHandler}>
                    {
                        schools && schools.map(e => (
                            <option key={e.id} value={e.id}>{e.name}</option>
                            ))
                    }
                </select>
                <button onClick={submitHandler} className={styles.button}>Register Student</button>

            </div>
        </div>

    )
}
export default CreateStudent