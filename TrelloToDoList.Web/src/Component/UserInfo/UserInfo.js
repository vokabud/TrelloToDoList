import React from 'react';
import './UserInfo.css';

class UserInfo extends React.Component {
  render() {
      return ( 
          <div className="user-name">
              User: <span>{this.props.name}</span> 
          </div>);
  }
}

export default UserInfo;
