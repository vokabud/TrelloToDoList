import React from 'react';
import { render } from '@testing-library/react';
import UserName from './UserName';

test('renders learn react link', () => {
  const { getByText } = render(<UserName name="name"/>);
  const linkElement = getByText(/name/i);
  expect(linkElement).toBeInTheDocument();
});
