import React, { Component } from 'react';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import SignIn from './components/auth/SignIn';
import SignUp from './components/auth/SignUp';
import ExpensePage from './components/pages/ExpensesPage';

class App extends Component {
  render() {
    return (
    <Router>
        <div>
          <Switch>
              <Route exact path='/' component={SignIn} />
              <Route path='/Expenses' component={ExpensePage} />
              <Route path='/signup' component={SignUp} />
              <Route path='/signin' component={SignIn} />
          </Switch>
        </div>
      </Router>
    );
  }
}

export default App;
