import React, { useState } from 'react'
import styles from '../../css/create.module.css'
import { SCHOOL_ADD_URL } from '../../store/constants'
import { useSelector } from 'react-redux'

const CreateSchool = () => {
    const { token } = useSelector(s=>s.UserReducer)
    const [name, setName] = useState('')
    const submitHandler = () => {
        fetch(SCHOOL_ADD_URL, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json',
                'Authorization': `Bearer ${token}`
            },
            body: JSON.stringify({ Name: name })
        })
            .then(res => res.json()).then(json => {
                if (json) {
                    alert("successfully registered")
                }
            })
            .catch(err => alert("unable to register"))

        setName('')
    }
    return (
        <div className={styles.container}>
            <h1>Register your school</h1>
            <div>
                <label htmlFor="fname">School Name</label>
                <input type="text" name="name" placeholder="Your name.." className={styles.global} value={name} onChange={(e) => setName(e.target.value)} />
                <button onClick={submitHandler} className={styles.button}>Register School</button>
            </div>
        </div>
        )
}
export default CreateSchool