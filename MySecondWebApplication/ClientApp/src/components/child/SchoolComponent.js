import React, { useEffect } from 'react'
import { useSelector, useDispatch } from 'react-redux'
import { fetchSchoolData } from '../../store/actions/SchoolAction'


const SchoolComponent = () => {
    const state = useSelector(state => state.SchoolReducer)
    const dispatch = useDispatch()

    useEffect(() => {
        dispatch(fetchSchoolData())
        return () => {

        }
    },[])
    return (
        <div>
            {
                state.loading ? <h1>Loading.......</h1> :
                    state.error ? <h1>Error :- {state.error}</h1> :
                        state.data && state.data.map(e => (
                            <h1 key={e.id}>{e.name}</h1>
                            ))
                        
            }
        </div>
        )
}
export default SchoolComponent