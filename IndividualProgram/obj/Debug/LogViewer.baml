   M S B A M L   `   `   `  ����P  LSimpleStringEncryptor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SimpleStringEncryptorSimpleStringEncryptor  5   	   %    SimpleStringEncryptor.LogViewer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SimpleStringEncryptor     5   	     � Title$  
Log Viewer��5   	   $��402.398��6   $��646.545��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ listBox��5      $��
6,10,198,6q�6#   �� 5   
   -   5         ��Name$ button��5      $��Update��6!   $��0,39,9,0q�62   $	��Top=�6D   $��Right=�6q   $��75��6�   $��62��6�   �� 5   
   -   5         ��Name$ comboBox��5       �� SelectedValuePath$ Content��6%   $��Right=�6A   $��0,9,5,0q�6]   $	��Top=�6n   $	��171��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��11(�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.224Q�6$   �� 5      T� 5       T� Y$ 0.208Q�6)   5      .@�5      �� $��Application opened��6   $
��Left=�68   $	��104��6S   �� 5      $��Application closed��6   $
��Left=�68   $	��104��6S   �� 5      $��Log file created��6   $
��Left=�66   $	��104��6Q   �� 5      $��Button clicked��6   $
��Left=�64   $	��104��6O   �� 5      $��Action completed��6   $
��Left=�66   $	��104��6Q   �� 5      $��Error��6   $
��Left=�6+   $	��104��6F   5      �� 5   
   -   5        	 ��Name$	 groupBox��5      $��Filter options��6%   $��Right=�6=   $��	0,39,89,0q�6Y   $��86��6l   $��62��6w   $	��Top=�6�   	� 5    
   -   5        
 	�Name$
 radioButtonByType��5       $��By type��61   $��
0,80,115,0q�6C   $	��Top=�6W   $ 
0.49,1.945&�6o   $��Right=�6�   $��58��6�   	� 5!   
   -   5        $
 radioButtonViewAll��5!      $��View all��62   $��
0,60,115,0q�6E   $	��Top=�6Y   $ 
0.49,1.945&�6q   $��Right=�6�   $��60��6�    d� 	IsChecked$
 TrueY�6�   5"      5#      