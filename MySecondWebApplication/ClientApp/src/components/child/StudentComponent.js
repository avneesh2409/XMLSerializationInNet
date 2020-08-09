import React, { useEffect } from 'react'
import { useSelector, useDispatch } from 'react-redux'
import { fetchStudentData } from '../../store/actions/StudentAction';
import styles from '../../css/styles.module.css'; 

const StudentComponent = () => {
    const state = useSelector(state => state.StudentReducer)
    const { token } = useSelector(state => state.UserReducer)
    const dispatch = useDispatch();
    useEffect(() => {
        dispatch(fetchStudentData(token))
        return () => {

        }
    },[])
    return (
        <div>
           
            {
                state.loading ? <h1>Loading.......</h1> :
                    state.error ?
                        <h1>{state.error}</h1> :
                        state.data &&
                        <table border='1' className={styles.studentTable}>
                    <thead>
                    <tr>
                        <th>
                            Id
                        </th>
                        <th>
                            Name
                        </th>
                        <th>
                            Address
                        </th>
                        <th>
                            School
                        </th>
                        </tr>
                    </thead>
                    <tbody>
                    {
                        state.data.map((e, i) => (
                            <tr key={i}>
                            <td>{e.id}</td>
                                <td>{e.name}</td>
                            <td>{e.address}</td>
                                <td>{e.schoolId}</td>
                            </tr>
                        ))
                        }
                    </tbody>
                    </table>
            }
                
        </div>
    )
}
export default StudentComponent