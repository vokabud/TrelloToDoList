import React from 'react';
import './UserName.css';

class UserName extends React.Component {
  render() {
      return ( 
          <div className="user-name">
            <p>
              User: <span>{this.props.name}</span> 
            </p>
          </div>);
  }
}

export default UserName;
