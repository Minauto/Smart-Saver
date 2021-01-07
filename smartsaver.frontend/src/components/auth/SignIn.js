import React, { Component } from 'react'

class SignIn extends Component {
    state = {

    }
    handleChange = (e) => {
        console.log(e)
    }
    handleSubmit = (e) => {
        console.log(e)
    }
    render() {
        return (
            <div className="container">
                <form onSubmit={ this.handleSubmit } className="white">
                    <h5 className="grey-text.text-darken-3">Sign In</h5>
                    <div className="input-field">
                        <label htmlFor="name">Name</label>
                        <input type="name" id="name" onChange={ this.handleChange } />
                    </div>
                    <div className="input-field">
                        <label htmlFor="name">Password</label>
                        <input type="password" id="password" onChange={ this.handleChange } />
                    </div>
                    <div className="input-field">
                        <button className="btn pink lighten-1 z-depth-0">Login</button>
                    </div>
                </form>
            </div>
        )
    }
}

export default SignIn