package com;

public class Tcpheader {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		StringBuffer sb = new StringBuffer();
		String sequenceNumber ="00000000";
		String acknowledgeNumber = "00000000";
		String flags_data ="51020000";//flags and other info
		String studentId = "8143687";//8136590
		int sourcePortTemp = Integer.parseInt(studentId.substring(3, 7));
		int destinationPortTemp = Integer.parseInt(studentId.substring(0,4));
		String sourcePort = Integer.toHexString(sourcePortTemp);
		String destinationPort = Integer.toHexString(destinationPortTemp);
		sb.append(sourcePort);
		sb.append(destinationPort);
		sb.append(sequenceNumber);
		sb.append(acknowledgeNumber);
		sb.append(flags_data);
		System.out.println(sb.toString());
	}

}
