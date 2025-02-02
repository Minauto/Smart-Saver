import React, { Component } from 'react'
import { Navbar } from 'react-bootstrap';
import Logo from './save-money.png';

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
            <>
                <Navbar bg="dark" variant="dark">
                    <Navbar.Brand style={{ fontFamily: 'Raleway' }}>
                        <img
                            alt=""
                            src={Logo}
                            width="30"
                            height="30"
                            className="d-inline-block align-top"
                        />{' '}
            Smart Saver
          </Navbar.Brand>
                </Navbar>
                <form>
                    <h3>Sign In</h3>

                    <div className="form-group">
                        <label>Username</label>
                        <input type="username" className="form-control" placeholder="Enter username" />
                    </div>

                    <div className="form-group">
                        <label>Password</label>
                        <input type="password" className="form-control" placeholder="Enter password" />
                    </div>

                    <div className="form-group">
                        <div className="custom-control custom-checkbox">
                            <input type="checkbox" className="custom-control-input" id="customCheck1" />
                            <label className="custom-control-label" htmlFor="customCheck1">Remember me</label>
                        </div>
                    </div>

                    <button type="submit" className="btn btn-primary btn-block">Submit</button>
                    <p className="forgot-password text-right">
                        Forgot <a href="#">password?</a>
                    </p>
                </form>
            </>
        )
    }
}

export default SignIn