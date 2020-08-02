import React from 'react';
import { useSelector } from 'react-redux';
import { useDispatch } from 'react-redux';
import { testAction } from '../store/actions/testAction';
//import { push } from '../store/actions/historyPush';

const Home = ({ history }) => {
    const { testReducer } = useSelector(state => state);
    const dispatch = useDispatch();
    return (
        <div>Hello from Home page
            <button onClick={() => dispatch(testAction("Hello I am here"))}>click here</button>
            {
                JSON.stringify({ ...testReducer })
            }
            <span onClick={()=>history.push("/home")} style={{color:'red',
                cursor:'pointer'
            }}>routing</span>
        </div>
        )
}

export default Home;