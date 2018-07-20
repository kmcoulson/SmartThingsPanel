import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import AddUser from "./AddUser"

class App extends Component {
    render() {
        return (
              <div className="App">
                    <header className="App-header">
                        <img src={logo} className="App-logo" alt="logo" />
                        <h1 className="App-title">P A N E L</h1>
                    </header>
                    <p className="App-intro">
                        Welcome to PANEL, the dashboard for SmartThings
                    </p>
                  <AddUser />
              </div>
        );
      }
}

export default App;
