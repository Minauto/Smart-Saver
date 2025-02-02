import ExpenseList from "../ExpenseList";
import ExpenseForm from "../ExpenseForm";
import { Navbar } from 'react-bootstrap';
import Logo from '../../save-money.png';
import { BrowserRouter, Switch, Route } from 'react-router-dom'

const App = () => (
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
    <div style={{ width: '60%', margin: 'auto', marginTop: '20px' }}>
      <h3>New Expense</h3>
      <ExpenseForm />
      <hr style={{ border: '1px solid grey' }} />
      <h3> Your Expenses</h3>
      <ExpenseList />
    </div>
  </>
);

export default App;