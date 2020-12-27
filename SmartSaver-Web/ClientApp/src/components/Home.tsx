import * as React from 'react';
import { connect } from 'react-redux';

const Home = () => (
  <div>
        <h1>Testing</h1>
        <h3>Hello world!</h3>
  </div>
);

export default connect()(Home);
