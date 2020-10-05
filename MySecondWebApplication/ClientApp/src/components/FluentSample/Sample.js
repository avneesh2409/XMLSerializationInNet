import React from 'react'
import { PrimaryButton } from '@fluentui/react';

const SampleComponent = () => {

    return (
        <>
            <PrimaryButton text="hello world" onClick={()=>console.log("we are going to college")}/>
            <h1>we are in sample project</h1>
        </>
    )
}
export default SampleComponent;