import React from 'react';
import './Header.css';
import '../UserInfo/UserInfo'
import UserInfo from '../UserInfo/UserInfo';

class Header extends React.Component {
  render() {
      return (
        <header>
          <div></div>
          <div className="app-name">
            Trello ToDo List
          </div>
          <div className="user-info">
            <UserInfo name="Oleg Dubakov"/>
          </div>
        </header>);
  }
}

export default Header;
