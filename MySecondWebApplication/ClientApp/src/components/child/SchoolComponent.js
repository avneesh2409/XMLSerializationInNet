import React, { useEffect } from 'react'
import { useSelector, useDispatch } from 'react-redux'
import { fetchSchoolData } from '../../store/actions/SchoolAction'
import styles from "../../css/styles.module.css"

const SchoolComponent = () => {
    const state = useSelector(state => state.SchoolReducer)
    const { token } = useSelector(state=>state.UserReducer)
    const dispatch = useDispatch()

    useEffect(() => {
        dispatch(fetchSchoolData(token))
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
                                </tr>
                            </thead>
                            <tbody>
                                {
                                    state.data.map((e, i) => (
                                        <tr key={i}>
                                            <td>{e.id}</td>
                                            <td>{e.name}</td>
                                        </tr>
                                    ))
                                }
                            </tbody>
                        </table>
            }

        </div>
        )
}
export default SchoolComponent